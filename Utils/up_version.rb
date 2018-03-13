require "yaml"

path = "../ProjectSettings/ProjectSettings.asset"
data = YAML.load_file(path)

versions = data['PlayerSettings']['bundleVersion'].split(".")
build = Integer(versions[2])
build = build + 1

versions[2] = build.to_s

newVersion = versions.join(".")

data['PlayerSettings']['bundleVersion'] = newVersion

File.open(path, 'w') { |f| YAML.dump(data, f) }
